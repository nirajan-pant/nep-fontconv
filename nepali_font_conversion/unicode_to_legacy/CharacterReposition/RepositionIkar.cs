using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nepali_Font_Converter.UnicodeToFont
{
    class RepositionIkar
    {
        public String reposIkar(String text)
        {
            //MessageBox.Show(text);
            String reposTextPart1 = "";
            String reposTextPart2 = text;
            int k;
            for (k = 0; k < reposTextPart2.Length; k++)
            {
                int i = 2, j = 0;
                if (reposTextPart2[k].CompareTo('ि')==0)
                {
                    while ((j = k - i) >= 0)
                    {
                        if (reposTextPart2[k - i].CompareTo('्')==0)
                        {
                            i = i + 2;
                        }
                        else
                        {
                            break;
                        }
                    }//ह ि म ा ल हिमाल k=1 i=2 प श ् च ि म k=4 j=4-2 
                    //MessageBox.Show("out of while k="+k+" i="+i);
                    String str = reposTextPart2.Substring(0, j + 1);
                    //MessageBox.Show(str);
                    String str1 = reposTextPart2.Substring(j + 1, k-j-1);
                    //MessageBox.Show(str1);
                    String str2 = reposTextPart2.Substring(k + 1);
                    //MessageBox.Show(str+"    "+str1+"    "+str2);
                    reposTextPart1 = reposTextPart1 + str + "ि" + str1;
                    reposTextPart2 = str2;
                    k = 0;
                }
            }
            return reposTextPart1 + reposTextPart2;
        }  
    }
}
