package coursework;

//Start of interface Movement used for observer pattern
public interface Movement {

	//methods execute and undo for classes implementing interface
	public void execute();
	public void undo();
}
//End of Movement interface