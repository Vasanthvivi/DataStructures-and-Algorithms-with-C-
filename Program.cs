using System;
namespace ConsolePdfPrinter
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] records = new int[] {1,2,3,4,5,6,7,8};

            binarysearch(8, 0, 7, records);
            int i;
            int j;
            //for (i = 0; i <= 4; i++)
            //{
            //    Console.Write("*");
            //    for (j = 0; j < 4; j++)
            //    {
            //        if (j == j - i)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //let star
            //for (i = 0; i <= 40; i++)
            //{
            //    for (j = 40; j >=i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(var l=0;l<i;l++)
            //    {
            //        if ((i % 2) != 0)
            //        {
            //            Console.Write(" ");
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //binary search
            Console.ReadLine();
            //PrintController printController = new StandardPrintController();
            //PrintDocument pdoc = new PrintDocument();
            //pdoc.PrinterSettings.PrinterName = args[0];
            //pdoc.PrintController = printController;
            //pdoc.DefaultPageSettings.Landscape = true;
            //pdoc.PrintPage += delegate (object sender, PrintPageEventArgs e)
            //{
            //    e.Graphics.DrawString(args[1], new Font("Times New Roman", 16), new SolidBrush(Color.Black), new RectangleF(20, 50, pdoc.DefaultPageSettings.PrintableArea.Width, pdoc.DefaultPageSettings.PrintableArea.Height));
            //};
            //try
            //{
            //    pdoc.Print();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Exception Occured While Printing", ex);
            //}
        }

        private static void binarysearch(int target, int start,int end,int[] items)
        {
            int inc;
            Console.WriteLine("target {0}, start {1}, end {2}", target, start, end);
            Console.WriteLine("items");
            foreach(var elements in items)
            {
                Console.WriteLine(elements);
            }
            //search begins
            var pivot = items.Length / 2;
            Console.WriteLine("pivot element index is " + pivot);
            Console.WriteLine("pivot element is " + items[pivot]);
            int pivotelement = items[pivot];
            if (target == pivotelement)
            {
                Console.WriteLine("target found " + pivotelement);
                return;
            }
            int size = 0;
            if(pivot != 0)
            {
                size = pivot;
            }
            int[] part = new int[size];
            if(target > pivotelement)
            {
                int j = 0;
                for(inc=pivot;inc<=end;inc++)
                {
                    part[j] = items[inc];
                    j++;
                }
                binarysearch(target, start, part.Length-1, part);
            }
            else
            {
                for (inc = 0; inc < pivot; inc++)
                {
                    part[inc] = items[inc];
                    Console.WriteLine("items now " + items[inc]);
                    Console.WriteLine("items after segrated " + part[inc]);
                }
                Console.WriteLine("records is going to be searched now is ");
                foreach(var ii in part)
                {
                    Console.WriteLine(ii);
                }
                binarysearch(target, start, pivot, part);
            }
        }
    }
}