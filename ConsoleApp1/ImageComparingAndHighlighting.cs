using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Drawing;
using Comparer = GroupDocs.Comparison.Comparer;
using GroupDocs.Comparison.Options;
using GroupDocs.Comparison.Result;
using GroupDocs.Comparison.Common;


namespace ConsoleApp1
{
    internal class ImageComparingAndHighlighting
    {
        //Comparer com = new Comparer();
        //public static void CompareImages()
        //{
        //    Comparer comparer = new Comparer(@"C:\Users\parthiban.murugan\Desktop\ImageComparison\reefreview-dev.tpinteractive.com_projectsPagenationMissing.png");
        //    CompareOptions options = new CompareOptions();
        //    // To get the difference summary, set it 'true'
        //    options.GenerateSummaryPage = false;
        //    //Add the target image
        //    comparer.Add(@"C:\Users\parthiban.murugan\Desktop\ImageComparison\reefreview-dev.tpinteractive.com_projectsV1.png");
        //    // Compare two images and save the resultant image
        //    comparer.Compare("C:\\Users\\parthiban.murugan\\Desktop\\ImageComparison\\comparisonResultImage5.jpg", options);
        //    var val1 = comparer.GetResultString();
        //    //comparer.Compare();
        //    //var val1 = comparer.GetResultString();
        //    ChangeInfo[] changes = comparer.GetChanges();
        //    //foreach (ChangeInfo change in changes)
        //    //{
        //    //    int i = 1;
        //    Console.WriteLine($"chnage {i} : {change.Text}");
        //    Console.WriteLine($"chnage {i} : {change.Id}");
        //    Console.WriteLine($"chnage {i} : {change.Box}");

        //    //    i++;
        //    //}            
        //}
        public static void CompareImages()
        {

            // Load source and target images
            string sourceImagePath = @"C:\Users\parthiban.murugan\Desktop\ImageComparison\April05\reefreview-stg.tpinteractive.com_projects_5549_documents_1_folders_alldocuments_page01.png";
            string targetImagePath = @"C:\Users\parthiban.murugan\Desktop\ImageComparison\April05\reefreview-stg.tpinteractive.com_projects_5219_documents_1_folders_alldocuments_page01.png";
            CompareOptions options = new CompareOptions();
            options.GenerateSummaryPage = true;
            options.DeletedItemStyle.HighlightColor = Color.Red;
            options.InsertedItemStyle.HighlightColor = Color.Red;

            SaveOptions saveOption = new SaveOptions();
            //var sOp = saveOption.CloneMetadataType.ToString();
            using (Comparer comparer = new Comparer(sourceImagePath))
            {
                comparer.Add(targetImagePath);
                comparer.Compare();

                ChangeInfo[] changes = comparer.GetChanges();
                if (!comparer.GetChanges().Length.Equals(0))
                {
                    comparer.Compare(@"C:\Users\parthiban.murugan\Desktop\ImageComparison\April05\Page01comparisonResult.png", saveOption, options);
                    foreach (ChangeInfo change in changes)
                    {
                        int i = 1;
                        Console.WriteLine($"chnage {i} : {change.Text}");
                        Console.WriteLine($"chnage {i} : {change.Id}");
                        Console.WriteLine($"chnage {i} : {change.Box}");
                        i++;
                    }
                }
            }
        }
            public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new System.Drawing.Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }
        public static void Main(string[] args)
        {
            CompareImages();
        }
    }
}
