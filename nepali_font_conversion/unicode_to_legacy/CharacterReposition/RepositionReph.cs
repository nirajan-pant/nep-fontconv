using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nepali_Font_Converter.UnicodeToFont
{
    class RepositionReph
    {
        public String reposReph(String text)//To reposition REPH
        {
            //MessageBox.Show(text);
            String reposTextPart1 = "";
            String reposTextPart2 = " "+text+"    ";
            String[] uFontSworSymb = { "ा", "ी", "ु", "ू", "ृ", "े", "ै", "ो", "ौ" };
            int k;
            //for solving "र्‍य" problem
            for (k = 0; k < reposTextPart2.Length; k++)
            {
                if (reposTextPart2[k].CompareTo('र') == 0 && reposTextPart2[k + 1].CompareTo('्') == 0 && reposTextPart2[k + 2].CompareTo('‍') == 0 && reposTextPart2[k + 3].CompareTo('य') == 0)
                {
                    reposTextPart2 = reposTextPart2.Substring(0, k) + "¥o" + reposTextPart2.Substring(k + 4);
                }
            }
            //for solving रेफ
            //MessageBox.Show(reposTextPart2);
            for (k = 1; k < reposTextPart2.Length; k++)
            {
                //if(k<reposTextPart2.Length-1)
                //MessageBox.Show("Entered for loop k=" + reposTextPart2[k] + "  k+1=" + reposTextPart2[k+1]);
                int i = 2, j = 0;
                if (reposTextPart2[k-1].CompareTo('्') != 0 && reposTextPart2[k].CompareTo('र') == 0 && reposTextPart2[k + 1].CompareTo('्') == 0)
                {
                    //MessageBox.Show("entered if condition");
                    while ((k + 1 + i) < reposTextPart2.Length)
                    {
                        if (reposTextPart2[k + 1 + i].CompareTo('्') == 0)
                        {
                            i = i + 2;
                        }
                        else
                        {
                            String s = reposTextPart2[k + 1 + i].ToString();
                            if (uFontSworSymb.Contains(s))
                            {
                                j = k + 1 + i;
                                break;
                            }
                            else
                            {
                                j = k + 1 + i - 1;
                                break;
                            }
                        }
                    }//न ि र ् व ा  च न k=1 i=2
                    //MessageBox.Show("out of while k="+k+" i="+i);
                    String str = reposTextPart2.Substring(0, k);
                    //MessageBox.Show(str);
                    String str1 = reposTextPart2.Substring(k + 2, (j + 1 - k - 2));
                    //MessageBox.Show(str1);
                    String str2 = reposTextPart2.Substring(j + 1);
                    //MessageBox.Show(str+"    "+str1+"    "+str2);
                    reposTextPart1 = reposTextPart1 + str + str1 + "{";
                    reposTextPart2 = str2;
                    k = 1;
                }
            }
            return reposTextPart1 + reposTextPart2;
        }  
    }
}
