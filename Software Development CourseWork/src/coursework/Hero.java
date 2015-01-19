package coursework;

//Start of Hero class which inherits from Character
public class Hero extends Character {

	//Constructor for Hero continues the parameters inherited from Character
	public Hero(int x, int y) {
		super(x, y);
		
	}
	//End of constructor

	//Creates an instance of Diet called edible used for strategy pattern
	protected Diet edible;

	//showDiet method 
	public void showDiet(){
		this.edible.diet();
	}
	//End of method
	
	//Get method for edible
	public Diet getEdible() {
		return edible;
	}
	//End of get method

	//Set method for edible
	public void setEdible(Diet edible) {
		this.edible = edible;
	}
	//End of set method
}
//End of Hero class