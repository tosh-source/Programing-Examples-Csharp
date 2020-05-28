using System;
using System.Text;

namespace HomeworkMobilePhone
{
    public class Display
    {
        private string displaySize;
        private string displayColors;

        public string DisplaySize
        {
            get { return displaySize; }
            set { displaySize = value; }
        }

        public string DisplayColors
        {
            get { return displayColors; }
            set { displayColors = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            if (DisplaySize == null || DisplaySize == string.Empty)
            {
                result.AppendLine("There is no display information.");
            }
            else
            {
                result.AppendLine("DisplaySize: " + this.DisplaySize);
            }

            if (DisplayColors == null || DisplayColors == string.Empty)
            {
                result.Append("There is no display colors information.");
            }
            else
            {
                result.Append("DisplayColors: " + this.DisplayColors);
            }

            return result.ToString();
        }
    }
}
