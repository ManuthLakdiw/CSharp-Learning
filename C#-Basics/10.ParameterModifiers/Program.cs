using ParameterModifiers.InModifier;
using ParameterModifiers.OutModifier;
using ParameterModifiers.ParamsModifier;
using ParameterModifiers.RefModifier;
using ParameterModifiers.ThisModifier;

namespace ParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // InMdf.InModifierDemo();

            // RefMdf.RefModifierDemo();

            // OutMdf.OutModifierDemo();

            // ParamsMdf.ParamsModifierDemo();

            "manuth".MakeCool("########");

            Player player1 = new Player("Manuth Lakdiw");
            Console.WriteLine(player1.Health);
        }
    }
}