/*
 * Created by SharpDevelop.
 * User: mohammedibrahim
 * Date: 2/3/2016
 * Time: 9:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using tessnet2;
using System.Text.RegularExpressions;

namespace Tesseract_OCR
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			ocr_demo();
		}

static void ocr_demo()
{

				//long i;
                var image = new Bitmap(@"e:\image.bmp");
                var ocr = new tessnet2.Tesseract();
                //ocr.SetVariable("tessedit_char_whitelist", "0123456789");
                ocr.Init(@"C:\Users\Mohammeds\Desktop\Tesseract_OCR\Tesseract_OCR\tessdata", "eng", false);
                 
                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (tessnet2.Word word in result)
                {	
                	Console.WriteLine(word.Text);
            	}
            Console.ReadKey();


        }
	}


}