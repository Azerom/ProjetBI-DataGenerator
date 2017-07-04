using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Candy : Element
    {
        public int IdType { get; set; }
        public int IdColor { get; set; }
        public int IdVariant { get; set; }
        public int IdTexture { get; set; }
        public int IdPackaging { get; set; }

        public int ID { get; set; }

        public static int count = 0;

        public Candy(int type, int color, int variant, int texture, int packaging)
        {
            this.ID = count;
            count++;
            this.IdType = type;
            this.IdColor = color;
            this.IdVariant = variant;
            this.IdTexture = texture;
            this.IdPackaging = packaging;
        }
        public static Candy[] Generate(Env env)
        {
            Candy[] output = new Candy[env.Datas["Type"].Length * env.Datas["Color"].Length * 
                env.Datas["Variant"].Length * env.Datas["Texture"].Length * env.Datas["Packaging"].Length];

            int i = 0;
            foreach(Type type in env.Datas["Type"])
            {
                foreach(Color color in env.Datas["Color"])
                {
                    foreach(Variant variant in env.Datas["Variant"])
                    {
                        foreach(Texture texture in env.Datas["Texture"])
                        {
                            foreach(Packaging packaging in env.Datas["Packaging"])
                            {
                                output[i] = new Candy(type.ID, color.ID, variant.ID, texture.ID, packaging.ID);
                                i++;
                            }
                        }
                    }
                }
            }

            return output;
        }
        public override string ToSQL()
        {
            return "INSERT INTO CANDY " +
                "(ID_CANDY, ID_TYPE, ID_COLOR, ID_VARIANT, ID_TEXTURE, ID_PACKAGING) VALUES (" +
                this.ID + ", " +
                this.IdType + ", " +
                this.IdColor + ", " +
                this.IdVariant + ", " +
                this.IdTexture + ", " +
                this.IdPackaging + ");";
        }
    }
}
