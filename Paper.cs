using System;

namespace UPPGIFT_1___AFFISCHUTSKICKET
{
    public class Paper
    {
        string type;
        float width;
        float height;


        public Paper(string type, float height, float width){
            this.type = type;
            this.width = width;
            this.height = height;
        }

        public float GetWeight(int gramsPerSqrmeter){
            float area = width * height; //area in squaremillimeters
            area /= 1000 * 1000; //area in squaremeters
            float weight = area * gramsPerSqrmeter;

            if(type == "C4") //If type is a letter, then double the weight
                weight *= 2;

            return weight;
        }
    }
}
