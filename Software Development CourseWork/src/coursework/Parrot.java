package coursework;

import java.util.Random;

//Start of Parrot class which extends Enemy class and implements Runnable class
public class Parrot extends Enemy implements Runnable {

	//creates int time and an instance of Random called rand
	private int time;
	Random rand = new Random();
	
	//Constructor for Parrot sets Parrot name to Parrot and sets the time to a random number for the thread
	public Parrot(){
		setName("Parrot");
		setTime(rand.nextInt(999));
	}
	//End of Parrot constructor

	//Get method for time
	public int getTime() {
		return this.time;
	}
	//End of get method
	
	//Set method for time
	public void setTime(int time) {
		this.time = time;
	}
	//End of set method
	
	//Start of method run
	@Override
	public void run() {
		
		//try catch that puts the thread to sleep or runs exception
		try {
			
			Thread.sleep(this.time);
			
		} catch (InterruptedException e) {
			
			e.printStackTrace();
		}
		//End of method run
	}
	//End of Parrot class
}
