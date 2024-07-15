//using System;
//using System.Linq;
//using System.Drawing;
//using System.Text.RegularExpressions;
//using System.Diagnostics;
//using System.Collections;
//using Emgu.CV;
//using Emgu.CV;
//using Emgu.CV.CvEnum;
//using Emgu.CV.Structure;
//using ImageMagick;

//namespace ConsoleApp1
//{
//    internal class ValidPalindrome
//    {
//        public static string s = "A man, a plan, a canal: Panama";

//        public static void isValidPalindrome(string value)
//        {
//            Regex regex = new Regex("[^a-zA-Z0-9 -]");
//            var val = regex.Replace(s, "");
//        }

//        class Pet
//        {
//            public string Name { get; set; }
//            public double Age { get; set; }
//        }

//        static List<Pet> petsList = new List<Pet>{
//                                new Pet { Name="Barley", Age=8.3 },
//                                new Pet { Name="Boots", Age=4.9 },
//                                new Pet { Name="Whiskers", Age=1.5 },
//                                new Pet { Name="Daisy", Age=4.3 },
//                                new Pet { Name="Daisy", Age=4.3 }
//        };
//        public static void copyFiles()
//        {

//            //var val = petsList.GroupBy(x => x.Name);
//            //var val1 = val.Where(x => x.Equals("Daisy"));
//            //foreach ( var val2 in val) {
//            //    Console.WriteLine(val2.Key);
//            //    Console.WriteLine(val2.Count());
//            //}


//            // Source file to be renamed  
//            //string sourceFile = @"C:\Users\parthiban.murugan\Desktop\LoadFiles\01_Clean_ColorImages\01_Clean_ColorImages\Images\00003\DOC0000000007_0011.jpg";
//            //// Create a FileInfo  
//            //System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);
//            // Check if file is there  
//            //List<string> ImageName = new List<string>();

//            //for (int i = 1; i <= 13; i++)
//            //{
//            //    //if (fi.Exists)
//            //    //{
//            //    //    // Move file with a new name. Hence renamed.  
//            //    //    fi.CopyTo($"C:\\Users\\parthiban.murugan\\Desktop\\LoadFiles\\01_Clean_ColorImages\\01_Clean_ColorImages\\Images\\00003\\DOC0000000007_{i.ToString().PadLeft(4, '0')}.jpg");
//            //    //    Console.WriteLine("File Copied.");
//            //    //}


//            //    ImageName.Add($"{i.ToString().PadLeft(8, '0')}.pdf");    

//            //}
//            //IEnumerable<string> filenames = Enumerable.Range(1, 13).Select(x => $"{x:D8}.pdf");
//            //foreach (string filename in filenames)
//            //{
//            //    Console.WriteLine(filename);
//            //}

//            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" , "Mazda" };
//            //var sts = cars.Distinct().Any();
//            //Console.WriteLine("Hello World");
//            //Console.WriteLine(sts);

//            //int[] numbers = { 4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8, 8 };
//            //int[] distinctNumbers = numbers.Distinct().ToArray();
//            //var grp = numbers.GroupBy(x => x).ToArray();
//            ////var grp = numbers.GroupBy().;
//            //var whr = grp.Where(g => g.Count() > 2);
//            //var slct = grp.Select(g => g.Key).ToArray();
//            //int[] duplicateNumbers = numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();

//            //Console.WriteLine("original array");
//            //foreach (var item in numbers)
//            //{
//            //    Console.Write(item);
//            //}

//            int countMulti = 0;
//            var Values = "1,2,3,4,5,1,2,3,4";
//            string[] CodeValues = Values.ToLower().Split(",");
//            string[] duplicateCodeValues = new string[CodeValues.Length];
//            for (int i = 1; i <= CodeValues.Length; i++)
//            {
//                for (int j = i + 1; j <= CodeValues.Length - i; j++)
//                {
//                    var val = CodeValues.ElementAt(i);
//                    var val1 = CodeValues.ElementAt(j);
//                    if (CodeValues.ElementAt(i).Equals(CodeValues.ElementAt(j)))
//                    {
//                        duplicateCodeValues[countMulti] = CodeValues.ElementAt(i);
//                        countMulti += 1;
//                    }
//                }
//            }
//            Console.WriteLine($"countMulti - {countMulti}");



//            //Console.WriteLine("\n distinct Numbers");
//            //foreach (var item in distinctNumbers)
//            //{
//            //    Console.Write(item);
//            //}

//            //Console.WriteLine("\n duplicate Numbers");
//            //foreach (var item in duplicateNumbers)
//            //{
//            //    Console.Write(item);
//            //}




//        }


//        //public static void main(string[] args) {
//        //    PdfDocument doc = new PdfDocument();
//        //    doc.Margins = new PdfMargins(10, 10, 0, 0);

//        //    // create a new pdf font
//        //    PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
//        //    font.Size = 24;

//        //    // add a new page to the document
//        //    PdfPage page = doc.AddPage();

//        //    // footer template (100 points in height) with text element
//        //    doc.Footer = doc.AddTemplate(doc.Pages[0].ClientRectangle.Width, 100);
//        //    PdfTextElement text1 = new PdfTextElement(0, 50,
//        //        "Page: {page_number} of {total_pages}.", font);
//        //    text1.ForeColor = System.Drawing.Color.Blue;
//        //    doc.Footer.Add(text1);

//        //    // create a new text element and add it to the page
//        //    // if page elements are added after header and footer is set, 
//        //    // they will not be displayed in those areas.
//        //    PdfTextElement text = new PdfTextElement(0, 0, Helper.SomeLongText(), font);
//        //    page.Add(text);

//        //    // save pdf document
//        //    doc.Save(Response, false, "Sample.pdf");

//        //    // close pdf document
//        //    doc.Close();
//        //}
//        //public static void main(string[] args) {
//        //    PdfDocument doc = new PdfDocument();
//        //    String inputFilePath = ;
//        //    String outputFilePath = ;
//        //    int startPageIndex = 1;
//        //    int numberOfPages = 5;
//        //    PdfPage page = doc.AddPage();
//        //    page.

//        //    //  insert 5 empty pages after first page
//        //    doc.AddEmptyPages(inputFilePath, startPageIndex, numberOfPages);

//        //    //PdfDocument document = new PdfDocument();

//        //    //for (int i = 0; i < 10; i++)
//        //    //{
//        //    //    //token.ThrowIfCancellationRequested();

//        //    //    PdfPage page = document.AddPage();
//        //    //    XGraphics gfx = XGraphics.FromPdfPage(page);
//        //    //    XFont font = new XFont("Verdana", 40, XFontStyle.Bold);
//        //    //    gfx.DrawString($"测试 Page {i + 1}", font, XBrushes.Black,
//        //    //    new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
//        //    //}
//        //    //document.Save(fileName);
//        //}
//        public static void checkContains()
//        {
//            string val = "Add To...\nAdd To ReefML Index\nTrain ReefML Model\nRemove From...\nCode\nDelete\nDelete Redactions\nImage\nReset Preview Generation Status\nDownload Native\nDownload Text\nDownload Image PDF\nDownload Produced PDF";
//            var sts = val.Equals("Add To ReefML Index");
//        }
//        public static void comareImages()
//        {
//            // Replace these file paths with your image file paths
//            string imagePath1 = @"C:\Users\parthiban.murugan\Desktop\ImageComparison\reefreview-dev.tpinteractive.com_projects.png";
//            string imagePath2 = @"C:\Users\parthiban.murugan\Desktop\ImageComparison\reefreview-dev.tpinteractive.com_projectsPagenationMissing.png";

//            // Load images
//            using (MagickImage image1 = new MagickImage(imagePath1))
//            using (MagickImage image2 = new MagickImage(imagePath2))
//            {
//                // Set a threshold for image comparison (adjust as needed)
//                double threshold = 0.1;

//                // Compare images
//                double difference = image1.Compare(image2, ErrorMetric.MeanAbsolute);

//                // Check if the difference is below the threshold
//                if (difference < threshold)
//                {
//                    Console.WriteLine("Images are similar.");
//                }
//                else
//                {
//                    Console.WriteLine("Images are not similar.");
//                }
//            }
//        }
//        public static void spliturl()
//        {
//            string s = "https://reefreview-stg.tpinteractive.com/projects/4251/search/current";
//            var val = s.Split('/')[4];
//        }


//        public static string ExecuteCommand(string command)
//        {
//            var processStartInfo = new ProcessStartInfo();
//            processStartInfo.FileName = "powershell.exe";
//            processStartInfo.Arguments = $"-Command \"{command}\"";
//            processStartInfo.UseShellExecute = false;
//            processStartInfo.RedirectStandardOutput = true;

//            using var process = new Process();
//            process.StartInfo = processStartInfo;
//            process.Start();
//            string output = process.StandardOutput.ReadToEnd();
//            Console.WriteLine(output);
//            return output;
//        }
//        public static void writeInFile()
//        {
//            var path = @"C:\Users\parthiban.murugan\Desktop\LoadFiles\sample.docx";
//            // Create a file to write to.
//            for (int i = 0; i < 1000; i++)
//            {
//                string createText = $"Hello and Welcome : {i} + {Environment.NewLine}";
//                File.WriteAllText(path, createText);
//            }
//            // Open the file to read from.
//            //string readText = File.ReadAllText(path);
//            //Console.WriteLine();


//        }
//        static double CompareImages(Bitmap image1, Bitmap image2)  // Basic Pixel-to-Pixel image comparison
//        {

//            var imgSize1 = image1.Size;
//            var imgSize2 = image2.Size;

//            if (image1.Size != image2.Size)
//                throw new ArgumentException("Images must have the same dimensions.");

//            int equalPixels = 0;
//            int totalPixels = image1.Width * image1.Height;

//            for (int x = 0; x < image1.Width; x++)
//            {
//                for (int y = 0; y < image1.Height; y++)
//                {
//                    if (image1.GetPixel(x, y) == image2.GetPixel(x, y))
//                        equalPixels++;
//                }
//            }

//            double similarityPercentage = (double)equalPixels / totalPixels * 100;
//            Console.WriteLine("Similarity Percentage " + similarityPercentage);
//            return similarityPercentage;
//        }

//        public static void bmpCheck()
//        {
//            // Load your image (replace "imagePath" with the path to your image file)
//            string imagePath1 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects1.png";
//            string imagePath2 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects3.png";

//            Image newImage = Image.FromFile(imagePath1);
//            Image newImage2 = Image.FromFile(imagePath2);





//            //Bitmap originalImage1 = new Bitmap(imagePath1);
//            //Bitmap originalImage2 = new Bitmap(imagePath2);
//            //var newImage1 = originalImage1;
//            //var newImage2 = originalImage2;
//            //if (newImage1.Equals(newImage2))
//            //{
//            //    Console.WriteLine("Equal");
//            //}

//        }

//        //public static bool Compare(System.Drawing.Image actualImage, System.Drawing.Image expectedImage)
//        //{

//        //}
//        private void ImageExampleForm_Paint()
//        {
//            // Create image.
//            Image newImage = Image.FromFile("SampImag.jpg");

//            //// Create Point for upper-left corner of image.
//            //Point ulCorner = new Point(100, 100);

//            //// Draw image to screen.
//            //e.Graphics.DrawImage(newImage, ulCorner);
//        }

//        //public void CompareImagesTest()  // using Graphics.FromImage
//        //{
//        //    // Perform UI actions to reach the desired state
//        //    // For example:
//        //    // var mainWindow = new WinWindow();
//        //    // mainWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Main Window";
//        //    // mainWindow.DrawHighlight();
//        //    // ...

//        //    // Capture screenshots
//        //    var screen = Screen.PrimaryScreen;
//        //    Bitmap screenshot1 = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
//        //    Graphics graphics = Graphics.FromImage(screenshot1 as Image);
//        //    graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
//        //    screenshot1.Save("screenshot1.png");

//        //    // Perform additional UI actions if needed

//        //    // Capture another screenshot
//        //    Bitmap screenshot2 = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
//        //    graphics = Graphics.FromImage(screenshot2 as Image);
//        //    graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
//        //    screenshot2.Save("screenshot2.png");

//        //    // Compare screenshots
//        //    bool areSimilar = AreImagesSimilar(screenshot1, screenshot2);

//        //    // Assert the comparison result
//        //    Assert.IsTrue(areSimilar, "Images are not similar.");
//        //}

//        public static void CompareImagesByOpenCVSSIM(string imgPath1, string imgPath2)
//        {
//            // Load images
//            Mat image1 = CvInvoke.Imread(imgPath1, ImreadModes.Grayscale);
//            Mat image2 = CvInvoke.Imread(imgPath2, ImreadModes.Grayscale);

//            // Ensure images have the same size
//            if (image1.Size != image2.Size)
//            {
//                Console.WriteLine("Images must have the same dimensions.");
//                return;
//            }

//            // Create a destination image for the comparison result
//            Mat comparisonResult = new Mat();

//            // Perform the comparison
//            CvInvoke.Compare(image1, image2, comparisonResult, CmpType.Equal);

//            // Compute the average SSIM value
//            double ssim = ComputeAverageSSIM(comparisonResult);

//            // Output SSIM value
//            Console.WriteLine($"SSIM: {ssim}");

//            // Dispose Mats
//            image1.Dispose();
//            image2.Dispose();
//            comparisonResult.Dispose();
//        }
//        //static double ComputeSSIM(Mat image1, Mat image2)
//        //{
//        //    // Convert Mats to Image<Gray, byte>
//        //    Image<Gray, byte> img1 = image1.ToImage<Gray, byte>();
//        //    Image<Gray, byte> img2 = image2.ToImage<Gray, byte>();

//        //    // Compute SSIM using Emgu.CV's SSIM method
//        //    double ssim = Emgu.CV.CvInvoke.Compare(img1, img2, ,Emgu.CV.CvEnum.CvEnum.CmpType.CcoeffNormed);

//        //    return ssim;
//        //}

//        static double ComputeAverageSSIM(Mat comparisonResult)
//        {
//            // Convert the comparison result to an Image<Gray, float>
//            Image<Gray, float> ssimImage = comparisonResult.ToImage<Gray, float>();

//            // Compute the average SSIM value
//            double ssimSum = ssimImage.GetSum().Intensity;
//            int pixelCount = comparisonResult.Width * comparisonResult.Height;
//            double averageSSIM = ssimSum / pixelCount;

//            return averageSSIM;
//        }
//        public static void ReverseString(string input)
//        {
//            char[] CharArray = input.ToCharArray();
//            string ReversedString = string.Empty;
//            for (int i = CharArray.Length - 1; i >= 0; i--)
//            {
//                ReversedString = ReversedString + CharArray[i];
//            }
//        }

//        public static void checkPalindrome()
//        {
//            var input = "Level11";
//            var reversed = input.Reverse();
//        }
//        public static void ReverseNumber()
//        {
//            //int a = 123;
//            //int ReverseNumber = 0;

//            //var rem = a % 10;
//            //ReverseNumber = ReverseNumber * 10 + rem;
//            //a = rem / 10;
//            int num = 12345;
//            int val = 0;

//            string reversed = num.ToString().Reverse().ToArray().Select(x => int.Parse(x.ToString())).ToArray().ToString();

//        }
//        public static string getPreviousMonthLastDate()
//        {
//            var today = DateTime.Today;
//            var month = new DateTime(today.Year, today.Month, 1);
//            var last = month.AddDays(-1);
//            var lastDateOfPreviousMonth = last.ToString("yyyy-MM-dd"); // last date of previous month
//            var currentMonthLastDate = month.AddMonths(1).AddDays(-2).ToString("yyyy-MM-dd"); // current Month Last Date -1
//            return lastDateOfPreviousMonth;
//        }

//        //public static void Main(string[] args)
//        //{

//        //}
//        public static void Main(string[] args)
//        {
//            //Load your image(replace "imagePath" with the path to your image file)
//            //string imagePath1 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects1.png";
//            //string imagePath2 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects2.png";
//            string imagePath1 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects_4434.png";
//            string imagePath2 = @"C:\Users\parthiban.murugan\Desktop\reefreview-stg.tpinteractive.com_projects_4456_Viewer_Doc01.png";
//            Bitmap originalImage1 = new Bitmap(imagePath1);
//            Bitmap originalImage2 = new Bitmap(imagePath2);
//            //isValidPalindrome(s);
//            //copyFiles();
//            //writeInFile();
//            //checkContains();
//            //comareImages();
//            //spliturl();
//            //UpdateJsonFile();
//            //ExecuteCommand("cd C:\\Users\\parthiban.murugan\\Desktop\\PSScriptHandsOn\\RT_36_Billing\\ProjectBillingEndpoint\\ProjectBilling");
//            //ExecuteCommand("k6 run CollectAndGenerateBilling.js");
//            // bmpCheck();
//            //CompareImagesTest();
//            //CompareImages(originalImage1, originalImage2);
//            //CompareImagesByOpenCVSSIM(imagePath1, imagePath2);
//            //checkPalindrome();
//            //ReverseNumber();
//            getPreviousMonthLastDate();
//        }
//    }
//}
