package coursework;
import javax.swing.JOptionPane;

//Start of VeryBigMac class which implements Diet used for strategy pattern
public class VeryBigMac implements Diet{

	//Method diet from implemented interface Diet which displays a message box when called
	@Override
	public void diet() {
		JOptionPane.showMessageDialog(null, "Diet Changed to Very Big Macs", null, JOptionPane.INFORMATION_MESSAGE);		
	}
	//End of diet method
}
//End of VeryBigMac class