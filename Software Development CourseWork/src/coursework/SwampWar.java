package coursework;

import java.util.Random;


//Start of SwampWar class
public class SwampWar {

	//Creates an instance of classes
	private DrawSwamp drawSwamp;
	private Ogre ogre;
	private Donkey donkey;
	private Snake snake;
	private Parrot parrot;

	//Creates new threads for ogre, donkey, snake and parrot
	Thread t1 = new Thread(ogre);
	Thread t2 = new Thread(donkey);
	Thread t3 = new Thread(snake);
	Thread t4 = new Thread(parrot);
	
	//ints created for laying out grid for the characters
	int[][] grid;
	static int height = 4; 
	static int width = 4;

	//Get method for ogre
	public Ogre getOgre() {
		return ogre;
	}

	//Set method for ogre
	public void setOgre(Ogre ogre) {
		this.ogre = ogre;
	}
	
	//Get method for grid
	public int[][] getGrid() {
		return grid;
	}

	//Set metho for grid
	public void setGrid(int[][] grid) {
		this.grid = grid;
	}

	//Constructor for SwampWar
	public SwampWar(DrawSwamp drawSwamp) {

		this.drawSwamp = drawSwamp;
	}
	//End of SwampWar constructor

	//Start of method boardGrid
	public void boardGrid(){
		grid = new int [width][];
		for (int x = 0; x < height; x++) {
				grid[x] = new int [width];
			
		}
		
		//Creates a instance of Random called rand and two ints called x and y
		Random rand = new Random();
		int x = 0;
		int y = 0;
		
		//loop saying while x and y = 0 it generates a random number within the height and width of the grid
		while ((x == 0) && (y == 0)) {
			x = rand.nextInt(width);
			y = rand.nextInt(height);
		}

		//sets randomly generated ints x and y to the ogre for its start position on the grid then calls refresh from DrawSwamp
		setOgre(new Ogre(x, y));
		drawSwamp.refresh();
	}
	//End of boardGrid method
	
	//Start of moveAround method takes one parameter Character c
	public void moveAround(Character c){

		//Creates an instance of the Movement children classes
		MoveN moveN = new MoveN(c);
		MoveS moveS = new MoveS(c);
		MoveE moveE = new MoveE(c);
		MoveW moveW = new MoveW(c);
		MoveNE moveNE = new MoveNE(c);
		MoveNW moveNW = new MoveNW(c);
		MoveSE moveSE = new MoveSE(c);
		MoveSW moveSW = new MoveSW(c);

		//Creates a instance of Random called random which generates a random numebr and then sets this to rand
		Random random = new Random();
		int rand = random.nextInt();

		//sets a switch case for the different available movements
		switch (rand) {
		case 1:
			moveN.execute();
			break;
		case 2:
			moveS.execute();
			break;
		case 3:
			moveE.execute();
			break;
		case 4:
			moveW.execute();
			break;
		case 5:
			moveNE.execute();
			break;
		case 6:
			moveNW.execute();
			break;
		case 7:
			moveSE.execute();
			break;
		case 8:
			moveSW.execute();
			break;
		}
		
		//tells the threads to start to separate the different characters moves and then calls refresh from DrawSwamp
		t1.start();
		t2.start();
		t3.start();
		t4.start();
		drawSwamp.refresh();
	}
	//End of moveAround mehtod
	
	//Start of undoMove method
	public void undoMove(){

		//Unfortunately didn't get this part coded
	}

	//Start of changeDiet method has one parameter String diet
	public void changeDiet(String diet){

		//if statement that says if diet equals Knight then change the ogres diet to Knights
		if (diet.equals("Knight")) {
			ogre.setEdible(new Knight());
		} 
		//if statement that says if diet equals Ogre Enemies then change the ogres diet to Ogre Enemy
		else if (diet.equals("Ogre Enemies")) {
			ogre.setEdible(new OgreEnemy());
		} 
		//if statement that says if diet equals Very Big Macs then change the ogres diet to Very Big Mac
		else if (diet.equals("Very Big Macs")) {
			ogre.setEdible(new VeryBigMac());
		}
	}
	//End of method changeDiet
}
//End of SwampWar class
