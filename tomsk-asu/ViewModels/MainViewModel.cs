using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using wpf_tomsk_asu.Models;

namespace wpf_tomsk_asu.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private EquationType equationType;
        private string[] equationTypes;
        private EquationModel equation;
        private int index;
        private int[] sourceArray = new int[] { 1, 2, 3, 4, 5 };
        private int[] variables = new int[] { 1, 2, 3, 4, 5 };
        private int variable;
        private double result;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public MainViewModel()
        {
            equationTypes = Enum.GetValues(typeof(EquationType)).OfType<EquationType>().Select(o => o.ToString()).ToArray();
            equation = new EquationModel();
        }
        
        public EquationType EquationTypes { get => equationType; }
        public EquationType SelectedType
        {
            get => equationType;
            set
            {
                if (equationType!= value)
                {
                    equationType = value;
                    OnPropertyChanged("SelectedType");
                    GetVar();
                    Calculate();
                    Variables = new ObservableCollection<int>(variables);
                }
            }
        }
        public int SelectedVariable
        {
            get => variable;
            set
            {
                if (variable != value)
                {
                    variable = value;
                    Calculate();
                    OnPropertyChanged("SelectedVariable");
                }
            }
        }
        public ObservableCollection<int> Variables
        {
            get => new ObservableCollection<int>(variables);
            set
            {
                if (new ObservableCollection<int>(variables) != value)
                {
                    variables = value.ToArray<int>();
                    OnPropertyChanged("Variables");
                }
            }
        }
        public string[] EqType
        {
            get => equationTypes;
            set
            {
                if (equationTypes != value)
                {
                    equationTypes = value;
                    OnPropertyChanged("EqType");
                }

            }
        }
        public double varA
        {
            get => equation.a;
            set
            {
                if (equation.a != value)
                {
                    equation.a = value;
                    Calculate();
                    OnPropertyChanged("varA");
                }
            }
        }
        public double varB
        {
            get => equation.b;
            set
            {
                if (equation.b != value)
                {
                    equation.b = value;
                    Calculate();
                    OnPropertyChanged("varB");
                }
            }
        }
        public double varX
        {
            get => equation.x;
            set
            {
                if (equation.x != value)
                {
                    equation.x = value;
                    Calculate();
                    OnPropertyChanged("varX");
                }
            }
        }
        public double varY
        {
            get => equation.y;
            set
            {
                if (equation.y != value)
                {
                    equation.y = value;
                    Calculate();
                    OnPropertyChanged("varY");
                }
            }
        }
        public double GetResult
        {
            get => result;
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged("GetResult");
                }
            }
        }

        private void GetVar()
        {
            for (int i = 0; i < equationTypes.Length; i++)
            {
                if (equationType.ToString() == equationTypes[i]) index = i;
            }
            for (int i = 0; i < variables.Length; i++)
            {
                variables[i] = (int)Math.Pow(10, index) * sourceArray[i];
            }
        }
       private void Calculate()
        {
            GetResult = Math.Pow(equation.x, index) * equation.a + Math.Pow(equation.y, index - 1) * equation.b + variable;
        }
    }
}
