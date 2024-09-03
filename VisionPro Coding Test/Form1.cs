
#define Cognex

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Cognex.VisionPro.Display;
using System.Diagnostics;
using System.Threading;


#if Cognex
using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Blob;
#endif

namespace VisionPro_Coding_Test
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        Cognex.VisionPro.Display.CogDisplay CogDisplay_Main = new Cognex.VisionPro.Display.CogDisplay();
        static public CogImageFileTool Image_Tool = new CogImageFileTool();
        static public CogImageFile Image_File = new CogImageFile();
        static public CogRectangle[,] Pattern_Search_Area = new CogRectangle[5, 4];
        public Button[] Select_Button = null;
        public static int Search_Area_Select = 0;
        static FileInfo fileinfo = new FileInfo(AppDomain.CurrentDomain.BaseDirectory);
        Public_Rect[,] Mark_Search_Arry = new Public_Rect[5, 4];
        CogImageConvertTool cogImageConvertTool = new CogImageConvertTool();
        CogImage8Grey CogImage_8Bit = new CogImage8Grey();
        CogBlobTool cogBlobTool = new CogBlobTool();
        Stopwatch StopWatch = new Stopwatch();
        

        public class Public_Rect
        {
            public double Left = 0;
            public double Top = 0;
            public double Width = 0;
            public double Height = 0;
        }

        private void Cmd_TEST_Load_1_Click(object sender, EventArgs e)
        {
            Load_Image((Button)sender);
        }

        private void Load_Image(Button Load_Button)
        {

            string[] bName = Load_Button.Name.Split('_');

            int DisplayPosition = Convert.ToInt32(bName[3]);
            string strTitle = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.bmp)|*.bmp";
            openFileDialog.Title = strTitle;
            Image_File = new CogImageFile();
            CogDisplay_Main = new CogDisplay();
#if Cognex
            cogDisplay_Main_1.AutoFit = true;
#endif

            CogDisplay_Main = cogDisplay_Main_1;
#if Cognex
            Single_Image_Load(Image_File, Image_Tool, CogDisplay_Main, openFileDialog);
#endif
        }

        private void Single_Image_Load(CogImageFile Image_File, CogImageFileTool Image_Tool, CogDisplay Display_Position, OpenFileDialog OFD)
        {
            try
            {
                string Path_Load_File = "";

                //// FolderBrowserDialog 생성
                if (OFD.ShowDialog() == DialogResult.OK)
                //대화상자(Dialog)를 띄운후 대화상자의 응답이 확인이라면,
                {

                    Path_Load_File = OFD.FileName;
                    //Path 변수에 선택된 폴더의 경로를 집어넣는다.

                    Image_File.Open(Path_Load_File, CogImageFileModeConstants.Read);
                    Image_Tool.Operator.Open(Path_Load_File, CogImageFileModeConstants.Read);
                    Image_Tool.Run();

                    Display_Position.Image = Image_Tool.OutputImage;

                    cogImageConvertTool.InputImage = Image_Tool.OutputImage;
                    cogImageConvertTool.Run();

                    CogImage_8Bit = new CogImage8Grey(cogImageConvertTool.OutputImage as CogImage8Grey);
                    Display_Position.Image = CogImage_8Bit;

                    cogBlobTool.InputImage = CogImage_8Bit;
                    cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardFixedThreshold;
                    cogBlobTool.RunParams.SegmentationParams.Polarity = CogBlobSegmentationPolarityConstants.DarkBlobs;
                    cogBlobTool.RunParams.SegmentationParams.HardFixedThreshold = 128;
                    cogBlobTool.RunParams.ConnectivityMode = CogBlobConnectivityModeConstants.GreyScale;
                    cogBlobTool.RunParams.ConnectivityMinPixels = 1000;
                    cogBlobTool.Run();


                    CogBlobResultCollection BlobResults = new CogBlobResultCollection();
                    CogPolygon[] blobPolygon = new CogPolygon[cogBlobTool.Results.GetBlobs().Count];
                    BlobResults = cogBlobTool.Results.GetBlobs();
                    for (int i = 0; i < cogBlobTool.Results.GetBlobs().Count; i++)
                    {
                        blobPolygon[i] = BlobResults[i].GetBoundary();

                        Point[] polygon = new Point[blobPolygon[i].NumVertices];
                        Point[] new_polygon = new Point[blobPolygon[i].NumVertices];

                        for (int j = 0; j < blobPolygon[i].NumVertices; j++)
                            polygon[j] = new Point((int)blobPolygon[i].GetVertexX(j), (int)blobPolygon[i].GetVertexY(j));

                    }

                    Display_Position.Image = cogBlobTool.Results.CreateBlobImage();
                    // CogBlob 출력 코드 공식

                    //Display_Position.Image = cogImageConvertTool.InputImage as CogImage8Grey;
                    //Display_Position.Image = Image_Tool.OutputImage;

                    Display_Position.AutoFit = true;
                    Display_Position.Fit(true);

                    // Blob_Setting_Change();
                }
            }
            catch (Exception e)
            {

            }
        }

        public void Blob_Setting_Change()
        {
            // 커밋 테스트

            ICogImage Display_image = cogDisplay_Main_1.Image;

            string Value_Threshold = NumericUpDown_ThresholdValue.Value + "";
            string Value_PixelSize = NumericUpDown_MinimalPixelSize.Value + "";

            int Int_Value_ThreShold = int.Parse(Value_Threshold);
            int Int_Value_PixelSize = int.Parse(Value_PixelSize);
            // NumericUpDown 컨트롤 숫자를 문자형으로 변환 후 정수형 변수 값으로 변환

            CogBlobSegmentationPolarityConstants Enum_Value_PolarityConstants = true ? CogBlobSegmentationPolarityConstants.DarkBlobs : CogBlobSegmentationPolarityConstants.LightBlobs;
            // Blob의 극성 값이 1이면 DarkBlobs, 0이면 LightBlobs로 설정한다.

            StopWatch.Start();
            Thread.Sleep(1000);
            cogBlobTool.InputImage = CogImage_8Bit;

            cogBlobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardFixedThreshold;

            cogBlobTool.RunParams.SegmentationParams.Polarity = Enum_Value_PolarityConstants;

            cogBlobTool.RunParams.ConnectivityMode = CogBlobConnectivityModeConstants.GreyScale;

            cogBlobTool.RunParams.SegmentationParams.HardFixedThreshold = Int_Value_ThreShold;

            cogBlobTool.RunParams.ConnectivityMinPixels = Int_Value_PixelSize;

            cogBlobTool.Run();

            StopWatch.Stop();

            CogBlobResultCollection BlobResults = new CogBlobResultCollection();
            CogPolygon[] blobPolygon = new CogPolygon[cogBlobTool.Results.GetBlobs().Count];
            BlobResults = cogBlobTool.Results.GetBlobs();

            for (int i = 0; i < cogBlobTool.Results.GetBlobs().Count; i++)
            {
                blobPolygon[i] = BlobResults[i].GetBoundary();

                Point[] polygon = new Point[blobPolygon[i].NumVertices];
                Point[] new_polygon = new Point[blobPolygon[i].NumVertices];

                for (int j = 0; j < blobPolygon[i].NumVertices; j++)
                    polygon[j] = new Point((int)blobPolygon[i].GetVertexX(j), (int)blobPolygon[i].GetVertexY(j));

            }

            cogDisplay_Main_1.Image = cogBlobTool.Results.CreateBlobImage();

        }

        private void Cmd_Main_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string[] StringArray_Segmentation_ModeData = { "HardFixedThreShold", "HardDynamicThreShold" };
            string[] StringArray_Connectivity_ModeData = { "GreyScale", "Total Image" };
            string[] StringArray_Segmentation_PolarityData = { "DarkBlobs", "BrightBlobs" };

            ComboBox_SegmentationMode.Items.AddRange(StringArray_Segmentation_ModeData);
            ComboBox_SegmentationMode.SelectedIndex = 0;
            // 폼의 세그먼테이션 모드 콤보 상자에 정적, 동적 설정 이후 정적모드를 콤보상자에 고정

            ComboBox_ConnectivityMode.Items.AddRange(StringArray_Connectivity_ModeData);
            ComboBox_ConnectivityMode.SelectedIndex = 0;
            // 폼의 연결 모드 콤보 상자에 '그레이스케일', '전체 이미지' 설정 이후 그레이스케일을 콤보상자에 고정

            ComboBox_Polarity.Items.AddRange(StringArray_Segmentation_PolarityData);
            ComboBox_Polarity.SelectedIndex = 0;
            // 폼의 세그먼테이션 극성 콤보 상자에 어두운 블랍, 밝은 블랍 설정 이후 어두운 블랍을 콤보상자에 고정

            ComboBox_SegmentationMode.Enabled = false;
            ComboBox_ConnectivityMode.Enabled = false;
            ComboBox_Polarity.Enabled = false;
            NumericUpDown_ThresholdValue.Enabled = false;
            NumericUpDown_MinimalPixelSize.Enabled = false;
            // 폼 내부 UI(User Interface)는 폼 로드되면 비활성화(임의 변경 불가능) 모드로 전환시킴

            
        }



        private void NumericUpDown_ThresholdValue_ValueChanged(object sender, EventArgs e)
        {
            Blob_Setting_Change();
        }

        private void NumericUpDown_MinimalPixelSize_ValueChanged(object sender, EventArgs e)
        {
            Blob_Setting_Change();
        }

        private void TextBox_PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            string String_Account = TextBox_Account.Text;
            string String_Password = TextBox_PassWord.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (String_Account.Equals("Admin") && String_Password.Equals("srd12345"))
                {
                    MessageBox.Show("로그인 완료", "LogIn");
                    ComboBox_SegmentationMode.Enabled = true;
                    ComboBox_ConnectivityMode.Enabled = true;
                    ComboBox_Polarity.Enabled = true;
                    NumericUpDown_ThresholdValue.Enabled = true;
                    NumericUpDown_MinimalPixelSize.Enabled = true;
                }
                else
                {
                    MessageBox.Show("로그인 실패, 다시 입력해주세요", "로그인");
                    ComboBox_SegmentationMode.Enabled = false;
                    ComboBox_ConnectivityMode.Enabled = false;
                    ComboBox_Polarity.Enabled = false;
                    NumericUpDown_ThresholdValue.Enabled = false;
                    NumericUpDown_MinimalPixelSize.Enabled = false;

                }
            }
            // 아이디, 비밀번호 입력하고 비밀번호 텍스트 상자에서 엔터 키 누를 때 발생하는 이벤트
        }
    }
}
