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
        public string BandName { get; set; } //название
        public string Country { get; set; } //страна
        public string StartYear { get; set; } //год создания
        public string Language { get; set; } //язык песен
        public List<string> Instruments { get; set; } //основные музыкальные инструменты
        public List<Genres> Genres { get; set; }  //поджанры
        public List<Members> Members { get; set; } //участники, поля: лидер, основной состав, для переопределенных + временные участники
    }
}
