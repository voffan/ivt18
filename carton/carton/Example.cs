using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    class Example
    {
        public enum Status { ok, wrong }
        public class TryClass //табличка TryClass
        {
            [Key] //первичный ключ действует только на !одно! поле после него
            public int TryClassId { get; set; } //столбец TryClassId, целочисленный
            //соответсвенно далее следуют другие различные свойства - столбцы
            public string Email { get; set; } //
            public string Address { get; set; } // ? - необязательное поле
            public Status Status { get; set; }

            public ICollection<ChildClass> ChildClasses { get; set; } //свойство, содержащее все объекты класса ChildClass, связанные с объектом класса TryClass
        }

        public class ChildClass //ссылки на внешние классы
        {
            [Key]
            public int ChildClassId { get; set; }
            public int TryClassId { get; set; } //связь с объектом класса TryClass
            [ForeignKey("TryClassId")] //в скобках - название поля, через которое связывается с классом TryClass
            public TryClass tryCl { get; set; }
        }

        public class ChildClass1 : TryClass
        {
            //[Key] наследуется автоматически
            public string FIO { get; set; }
        }
    }
}
