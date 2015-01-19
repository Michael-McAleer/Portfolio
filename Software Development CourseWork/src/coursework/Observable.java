package coursework;

//interface Observable for observer pattern
public interface Observable {

	//Methods for implementing classes
	void register(Character c);
	void notify(Character c);
}
//End of Observable interface