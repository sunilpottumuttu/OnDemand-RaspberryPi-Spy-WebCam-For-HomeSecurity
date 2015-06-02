using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PiSpyWebCam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connect the Webcam to Raspberry Pi

            //http://www.joshwright.com/tips/sending-receiving-email-in-csharp

            //Take the screenshot from Raspberrypi WebCam
            //https://www.raspberrypi.org/documentation/usage/webcams/
            Process.Start(new ProcessStartInfo("fswebcam", "image.jpg") { UseShellExecute = false }).WaitForExit();

            //How To Transfer the files from Dev Machine to RaspberryPi
            //http://www.neil-black.co.uk/transfer-files-across-your-network-from-windows-to-a-raspberry-pi#.VW2UBUZ9VsU


            //Install Mono
            //Execute the command mono SpyWebCam.exe


        }
    }
}
