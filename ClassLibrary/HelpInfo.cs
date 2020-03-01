using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IHelpInfo
    {
        string Content { get; }
    }
    public class HelpInfo: IHelpInfo
    {
        string Info = @"Конвертер

Авторы: 

        Татаринцев Артем
        Подвойский Кирилл
        Колесов Михаил

Группа: ПМИ-71";
        public string Content 
        { 
            get { return Info; }
        }
    }
}
