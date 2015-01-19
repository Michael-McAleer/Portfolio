package coursework;
import javax.swing.JOptionPane;

//Start of Knight class which implements Diet used for strategy pattern
public class Knight implements Diet{

	//Method diet from implemented interface Diet which displays a message box when called
	@Override
	public void diet() {
		JOptionPane.showMessageDialog(null, "Diet Changed to Knights in Shininh Armour", null, JOptionPane.INFORMATION_MESSAGE);		
	}
	//End of diet method
	
}
//End of Knight class
