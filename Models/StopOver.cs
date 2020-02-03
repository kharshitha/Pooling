using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StopOver
    {
        public StopOver(float vacancies)
        {
            this.Vacancies = vacancies;
        }
        public string Place { get; set; }
        public float Vacancies { get; set; }
    }
}
