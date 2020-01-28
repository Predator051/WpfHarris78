using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHarris78.Src.NTree
{
    class NTreeParamNode
    {
        List<NTreeParamNode> _childs = new List<NTreeParamNode>();
        NTreeParamNode _parent;

        string _name;
        string _value;

        bool IsNeedCheck = false;

        public NTreeParamNode(string name, string value, NTreeParamNode parent)
        {
            _name = name;
            _value = value;
            _parent = parent;
        } 

        public NTreeParamNode (string name, string value):
            this(name, value, null)
        {}

        public bool IsContainChild (string name)
        {
            return FindChild(name) != null;
        }

        public bool IsHasParent ()
        {
            return _parent != null;
        }

        public NTreeParamNode FindChild (string name)
        {
            return _childs.Find(node => node.Name == name);
        }

        public NTreeParamNode AddChild (string name, string value)
        {
            NTreeParamNode newNode = new NTreeParamNode(name, value, this);
            _childs.Add(newNode);
            return newNode;
        }

        public NTreeParamNode AddChild (NTreeParamNode newChild)
        {
            _childs.Add(newChild);
            newChild.Parent = this;
            return newChild;
        }

        public NTreeParamNode FindNode (string name)
        {
            if (Name == name) return this;

            var childResult = FindChild(name);
            if (childResult == null)
            {
                foreach (var child in _childs)
                {
                    childResult = child.FindChild(name);
                    if (childResult != null) return childResult;
                }
            }

            return childResult;
        }

        public string Name { get => _name; set => _name = value; }
        public string Value { get => _value; set => _value = value; }
        internal List<NTreeParamNode> Childs { get => _childs; set => _childs = value; }
        internal NTreeParamNode Parent { get => _parent; set => _parent = value; }
        public bool IsNeedCheck1 { get => IsNeedCheck; set => IsNeedCheck = value; }

        public override string ToString()
        {
            string res = recursiveToString(this, 0);
            return res;
        }

        private string recursiveToString(NTreeParamNode node, int countTabs)
        {
            string tabs = new string('\t', countTabs);
            tabs += $"{Name}:{Value}\n";
            foreach(var child in node.Childs)
            {
                tabs += child.recursiveToString(child, countTabs + 1);
            }
            return tabs;
        }
    }

    class NTreeParam
    {
        NTreeParamNode _node;

        public NTreeParam(string name, string value)
        {
            _node = new NTreeParamNode(name, value);
        }

        public void AddBranch(NTreeParamNode branch)
        {
            var branchRoot = _node.FindNode(branch.Name);

            if (branchRoot == null)
            {
                _node.AddChild(branch);
                return;
            }

            foreach (var branchChild in branch.Childs.ToArray())
            {
                AddNodeRecursive(branchRoot, branchChild);
            }
        }

        public static void AddNodeRecursive(NTreeParamNode parent, NTreeParamNode child)
        {
            if (parent.IsContainChild(child.Name))
            {
                foreach (var childChild in child.Childs)
                {
                    AddNodeRecursive(parent.FindChild(child.Name), childChild);
                }
                return;
            }
            parent.AddChild(child);
        }

        public override string ToString()
        {
            return _node.ToString();
        }

    }
}
