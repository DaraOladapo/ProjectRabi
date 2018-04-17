using Rabi.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabi.Desktop.HelperServices
{
    public class AppTaskService
    {
        public static List<AppTask> GetAppTasks()
        {
            return new List<AppTask>()
            {
                //Vision
                new AppTask(){Category=Category.Vision,ImageSource="Assets/Icons/Face.png", Task="Computer Vision API", Description="Distill actionable information from images"},
                new AppTask(){Category=Category.Vision,ImageSource="Assets/Icons/Face.png", Task="Face API", Description="Detect, identify, analyze, organize, and tag faces in photos"},
                new AppTask(){Category=Category.Vision,ImageSource="Assets/Icons/Face.png", Task="Emotion API", Description="Personalize user experiences with emotion recognition"},
                //Speech
                new AppTask(){Category=Category.Speech,ImageSource="Assets/Icons/Speech.png", Task="", Description=""},

                //Language
                new AppTask(){Category=Category.Language,ImageSource="Assets/Icons/Language.png", Task="", Description=""},

                //Knowledge
                new AppTask(){Category=Category.Knowledge,ImageSource="Assets/Icons/Knowledge.png", Task="", Description=""},

                //Search
                new AppTask(){Category=Category.Search,ImageSource="Assets/Icons/Search.png", Task="", Description=""},

            };
        }
    }
}
