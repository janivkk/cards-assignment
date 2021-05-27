using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace A3FINAL
{
    class TimeComplexity : DeckEnum
    {
        public void SaveTheFindings()
        {
            string saveTimeTaken = timeThatTakesToGetThrough.ToString();
            File.WriteAllText("timecomplexity.txt", saveTimeTaken);
        }
    }
}
