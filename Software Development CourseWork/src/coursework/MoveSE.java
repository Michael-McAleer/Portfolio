package coursework;

import java.util.ArrayList;

//Start of class MoveSE which implements Movement and Observable this is used for both the command pattern and observer pattern
public class MoveSE implements Movement, Observable{

	//Creates an instance of Character and an array of Characters also a String called moved for the observer pattern
	private Character ch;
	private ArrayList <Character> myCharacters = new ArrayList <Character>();
	String moved;
	
	//Set method for moved
	public void setMoved(String moved) {
		this.moved = moved;
	}
	//End of set method

	//Constructor for MoveSE has one parameter Character ch sets ch to equal ch
	public MoveSE(Character ch){
		this.ch = ch;
	}
	//End of constructor

	//Start of method execute inherited from interface Movement for the command pattern
	@Override
	public void execute() {

		int xpos = ch.getPosX();  
		if( xpos < SwampWar.height ) {  
			ch.setPosY( --xpos );  
		}

		int ypos = ch.getPosY();  
		if( ypos < SwampWar.height ) {  
			ch.setPosY( --ypos );
		} 
	}
	//End of method execute

	//Start of undo method inherited from interface Movement for the command pattern
	@Override
	public void undo() {

		int xpos = ch.getPosX();  
		if( xpos < SwampWar.height ) {  
			ch.setPosY( ++xpos );  
		}

		int ypos = ch.getPosY();  
		if( ypos > 0 ) {  
			ch.setPosY( ++ypos );  
		}		
	}
	//End of undo method
	
	//Start of method register inherited from interface Observable used for observer pattern
	@Override
	public void register(Character c) {
		this.myCharacters.add(c);	
	}
	//End of method register

	//Start of method notify inherits from interface Observable used for observer pattern
	@Override
	public void notify(Character c) {
		
		for(Character tempCharacter : this.myCharacters){
			tempCharacter.update(this.moved);
		}		
	}
	//End of method notify
}
//End of MoveSE class