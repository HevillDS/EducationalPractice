using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    class Band 
    {
        public string BandName; //название
        public string Country; //страна
        public string StartYear; //год создания
        public string Language; //язык песен
        public List<string> Instruments; //основные музыкальные инструменты
        public List<Genres> Genres;  //поджанры
        public List<Members> Members; //участники, поля: лидер, основной состав, для переопределенных + временные участники
    }
}
