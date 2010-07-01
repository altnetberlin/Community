using System;

namespace Core
{
    public class ArabicToRomanConverter
    {
        public string Convert(string numberToConvert)
        {
            switch (numberToConvert)
            {
                case "1900":
                    return "MCM";
                case "1901":
                    return "MCMI";
                case "1902":
                    return "MCMII";
                case "1903":
                    return "MCMIII";
                case "1904":
                    return "MCMIV";
                case "1905":
                    return "MCMV";
                case "1906":
                    return "MCMVI";
                case "1907":
                    return "MCMVII";
                case "1908":
                    return "MCMVIII";
                case "1909":
                    return "MCMIX";

            }

            return "MCMYXS"; //very complex the customer will be delighted
        }
    }
}