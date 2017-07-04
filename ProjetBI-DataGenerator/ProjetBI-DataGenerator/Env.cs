using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetBI_DataGenerator.Model;

namespace ProjetBI_DataGenerator
{
    class Env
    {
        private Dictionary<string, Model.Element[]> datas;

        public Dictionary<string, Element[]> Datas { get => datas; set => datas = value; }

        public Env(Config conf)
        {
            datas = new Dictionary<string, Element[]>();
            import("Shipping", typeof(Shipping), conf.Shipping);
            import("Country", typeof(Country), conf.Country);
            import("Color", typeof(Color), conf.Color);
            import("Type", typeof(Model.Type), conf.Type);
            import("Variant", typeof(Model.Variant), conf.Variant);
            import("Packaging", typeof(Packaging), conf.Packaging);
            import("Price", typeof(Price), conf.Price);
            import("Texture", typeof(Texture), conf.Texture);
            import("Component", typeof(Component), conf.Component);
            import("Component_Gramme", typeof(Component_Gramme), conf.ComponentGramme);
            import("Conditioning", typeof(Conditioning), conf.Conditioning);
            import("Fabrication", typeof(Fabrication), conf.Fabrication);
            
            


            Datas.Add("Candy", Candy.Generate(this));

        }

        private void import(string lib, System.Type clname, Dictionary<string, object>[] dicos)
        {
            Object[] para = new Object[1];
            para[0] = dicos;

            Element[] elem = (Model.Element[])clname.GetMethod("Import").Invoke(this, para);

            Datas.Add(lib, elem);
        }
    }
}
