using System.ComponentModel;
using System.Runtime.CompilerServices;

var foo = new Foo();
foo.PropertyChanged += (sender, args) => Console.WriteLine("Property changed!");
foo.CustomerName = "asdf";

Console.ReadLine();

public class Foo : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    void RaisePropertyChanged([CallerMemberName] string propertyName = null)
      => PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

    string customerName;
    public string CustomerName
    {
        get => customerName;
        set
        {
            if (value == customerName) return;
            customerName = value;
            RaisePropertyChanged();
            // The compiler converts the above line to:
            // RaisePropertyChanged ("CustomerName");
        }
    }
}