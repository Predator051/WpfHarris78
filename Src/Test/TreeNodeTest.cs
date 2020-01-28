using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHarris78.Src.NTree;

namespace WpfHarris78.Src.Test
{
    public class TreeNodeTest
    {
        public static void Testing()
        {
            NTreeParam nTree = new NTreeParam("Root", "RootValue");

            NTreeParamNode branch = new NTreeParamNode("Root", "None");
            var level10 = branch.AddChild("Level1.0", "Level1.0Value");
            level10.AddChild("Level1.0.0", "Level1.0.0Value");
            level10.AddChild("Level1.0.1", "Level1.0.1Value");
            var level11 = branch.AddChild("Level1.1", "Level1.1Value");
            level11.AddChild("Level1.1.1", "Level1.1.1Value");
            var level12 = branch.AddChild("Level1.2", "Level1.2Value");
            level12.AddChild("Level1.2.1", "Level1.2.1Value");
            level12.AddChild("Level1.2.2", "Level1.2.2Value");
            level12.AddChild("Level1.2.3", "Level1.2.3Value");

            nTree.AddBranch(branch);
            nTree.AddBranch(level12);

            NTreeParamNode branch2 = new NTreeParamNode("Root2", "None2");
            var level210 = branch2.AddChild("Level21.0", "Level21.0Value");
            level210.AddChild("Level21.0.0", "Level21.0.0Value");
            level210.AddChild("Level21.0.1", "Level21.0.1Value"); 
            
            nTree.AddBranch(branch2);

            NTreeParamNode branch3 = new NTreeParamNode("Level1.2", "None2");
            branch3
                .AddChild("Level1.2.1", "Level21.0Value")
                .AddChild("Leha", "LehaVal");

            nTree.AddBranch(branch3);

            Debug.WriteLine(nTree.ToString());
        }
    }
}
