package coursework;

import javax.swing.JOptionPane;

//Start of Character class which implements Observer and DisplayElement interfaces
public class Character implements Observer, DisplayElement{

	//Craetes Variables for passing to inheriting classes
	private String name;
	private String update;
	private int posX;
	private int posY;
	
	//Constructor for Character has two parameters int x and int y which pass to inheriting classes
	public Character(int x, int y){
		
		//Calls set methods for posX and posY
		setPosX(x);
		setPosY(y);
	}
	//End of Character constructor
	
	//Get name method
	public String getName() {
		return name;
	}
	//End of get method

	//Set name method
	public void setName(String name) {
		this.name = name;
	}
	//End of set method
	
	//Get method for posX
	public int getPosX() {
		return posX;
	}
	//End of get method

	//Set method for posX
	public void setPosX(int posX) {
		this.posX = posX;
	}
	//End of set method
	
	//Get method for posY
	public int getPosY() {
		return posY;
	}
	//End of get method

	//Set method for posY
	public void setPosY(int posY) {
		this.posY = posY;
	}
	//End of set method

	//Start of display method for observer pattern
	@Override
	public void display() {
		
		//Sets the move string and then outputs it to a message box
		String move = this.name + "Has moved to" + "\n";
		move = move + this.update;
		JOptionPane.showMessageDialog(null, move, null, JOptionPane.INFORMATION_MESSAGE);
		
	}
	//End of display method
	
	//Start of update method used for observer pattern
	@Override
	public void update(String moved) {
		
		//sets update to equal move then calls display
		this.update = moved;
		display();
		
	}
	//End of update method
	
}
//End of Character class
