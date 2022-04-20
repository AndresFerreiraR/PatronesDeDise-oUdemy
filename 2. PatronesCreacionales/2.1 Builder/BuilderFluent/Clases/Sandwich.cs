using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFluent.Clases
{
    public class Sandwich
    {
        /// <summary>
        /// 
        /// </summary>
        public string Bread { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Veggies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Protein { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Condiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Cheese { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Sandwich()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Bread"></param>
        /// <param name="_Veggies"></param>
        /// <param name="_Protein"></param>
        /// <param name="_Condiments"></param>
        /// <param name="_Cheese"></param>
        public Sandwich(string _Bread, string _Veggies, string _Protein, string _Condiments, string _Cheese)
        {
            this.Bread = _Bread;
            this.Veggies = _Veggies;
            this.Protein = _Protein;
            this.Condiments = _Condiments;
            this.Cheese = _Cheese;
        }
    }
}
