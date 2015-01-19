package coursework;

import java.util.Random;

//Start of EnemyFactory class used for Factory pattern
public class EnemyFactory {

	//Constructor for Enemy takes a randomly generated number between 1 and 3 and creates a new enemy depending on number generated
	public Enemy createEnemy() {
		Random random = new Random();
		int rand = random.nextInt(3) + 1;
		
		Enemy e = null;
		switch (rand) {
			case 1:
				e = new Donkey();
				break;
			case 2:
				e = new Parrot();
				break;
			case 3:
				e = new Snake();
				break;
		}
		
		return e;
	}
	//End of Constructor
}
//End of EnemyFactory class 