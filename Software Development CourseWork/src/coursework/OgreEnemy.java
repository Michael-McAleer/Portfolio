package coursework;
import javax.swing.JOptionPane;

//Start of OgreEnemy class which implements Diet used for strategy pattern
public class OgreEnemy implements Diet{

	//Method diet from implemented interface Diet which displays a message box when called
	@Override
	public void diet() {
		JOptionPane.showMessageDialog(null, "Diet Changed to Ogre Enemiesr", null, JOptionPane.INFORMATION_MESSAGE);		
	}
	//End of diet method
}
//End of OgreEnemy class