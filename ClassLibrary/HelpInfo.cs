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

Группа: ПМИ-71

Приложение «Конвертор р1_р2» под Windows 
для преобразования действительных чисел 
представленных в системе счисления с основ-
анием p1 в действительные числа представлен-
ные в системе счисления с основанием p2.";
        public string Content 
        { 
            get { return Info; }
        }
    }
}
