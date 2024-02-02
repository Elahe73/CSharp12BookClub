#region Exampe1

// A subclass can reimplement any interface member already implemented by a base class.
// Reimplementation hijacks a member implementation (when called through the interface):

// Calling the reimplemented member through the interface calls the subclass’s implementation:
//RichTextBox r = new RichTextBox();
//r.Undo();                 // RichTextBox.Undo      Case 1
//((IUndoable)r).Undo();    // RichTextBox.Undo      Case 2

//Console.ReadKey();

//public interface IUndoable { void Undo(); }

//public class TextBox : IUndoable
//{
//    void IUndoable.Undo() => Console.WriteLine("TextBox.Undo");
//}

//public class RichTextBox : TextBox, IUndoable
//{
//    public new void Undo() => Console.WriteLine("RichTextBox.Undo");
//}

#endregion

#region Exampe2

// Suppose that TextBox instead implemented Undo implicitly:

// This would give us another way to call Undo, which would “break” the system, as shown in Case 3:

//RichTextBox r = new RichTextBox();
//r.Undo();                 // RichTextBox.Undo      Case 1
//((IUndoable)r).Undo();    // RichTextBox.Undo      Case 2
//((TextBox)r).Undo();      // TextBox.Undo          Case 3

//Console.ReadKey();

//public interface IUndoable { void Undo(); }

//public class TextBox : IUndoable
//{
//    public void Undo() => Console.WriteLine("TextBox.Undo");
//}

//public class RichTextBox : TextBox, IUndoable
//{
//    public new void Undo() => Console.WriteLine("RichTextBox.Undo");
//}

#endregion

#region Exampe3

// Even with explicit member implementation, interface reimplementation is problematic for a
// couple of reasons.

// The following pattern is a good alternative if you need explicit interface implementation:

IUndoable r = new RichTextBox();
r.Undo();    // RichTextBox.Undo

Console.ReadKey();

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
    void IUndoable.Undo() => Undo();    // Calls method below
    protected virtual void Undo() => Console.WriteLine("TextBox.Undo");
}

public class RichTextBox : TextBox
{
    protected override void Undo() => Console.WriteLine("RichTextBox.Undo");
}

#endregion