package coursework;

import java.util.Random;

//Start of Ogre class which extends Hero class and implements Runnable class
public class Ogre extends Hero implements Runnable{
	
	//creates int time and an instance of Random called rand
	private int time;
	Random rand = new Random();
	
	//Constructor for Ogre with parameters int x and int y inherited from parent class, also sets Ogres name to HEK, his diet to Knight and sets the time to a random number for the thread 
	public Ogre(int x, int y){
		super(x,y);
		setName("HEK");
		this.edible = new Knight();
		setTime(rand.nextInt(999));
	}
	//End of Ogre constructor

	//Get method for time
	public int getTime() {
		return this.time;
	}
	
	//Set method for time
	public void setTime(int time) {
		this.time = time;
	}
	
	//Start of method run
	@Override
	public void run() {
		
		//try catch that puts the thread to sleep or runs exception
		try {
			Thread.sleep(this.time);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	//End of method run
}
//End of Ogre class