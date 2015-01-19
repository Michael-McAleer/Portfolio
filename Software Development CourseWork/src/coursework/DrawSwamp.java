package coursework;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JFrame; 
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.border.LineBorder;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

//Start of DrawSwamp class this class is for setting up the GUI
public class DrawSwamp{

	//Creates an instance of classes
	SwampWar game;
	Ogre ogre;
	Enemy enemy;

	//Creates two ints called width and height for setting the cell size on GUI
	public static int width = 90;
	public static int height = 90;

	//Creates the Frame, the Panel, the Buttons and the Labels for the GUI
	private JFrame frame = new JFrame();
	private JPanel backBoard = new JPanel();
	private JButton btnMove = new JButton("Move");
	private JButton btnUndo = new JButton("Undo");
	private JRadioButton btnKnights = new JRadioButton();
	private JRadioButton btnBigMac = new JRadioButton();
	private JRadioButton btnOgreEnemy = new JRadioButton();
	private JLabel lblKnight = new JLabel("Knights");
	private JLabel lblMac = new JLabel("Very Big Macs");
	private JLabel lblOgreEnemy = new JLabel("Ogre Enemies");

	public static void main(String[] args){

		DrawSwamp draw = new DrawSwamp();
		SwampWar game = new SwampWar(draw);
		game.boardGrid();
		
		

	}

	//Constructor for DrawSwamp
	DrawSwamp(){

		//Creates a new instance of SwampWar
		game = new SwampWar(this);
		
		//Sets the size of the GUI board
		int numRows = 4;
		int numCols = 4;

		//Sets the size of the Frame and the Panel also Gives it a title
		frame.setSize(450, 600);
		backBoard.setSize(500, 500);
		frame.setTitle("Swamp Wars");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
		backBoard.setVisible(true);

		//sets the size of btnMove and tells the system what to do when it is pressed
		btnMove.setVisible(true);
		btnMove.setBounds(100, 420, 75, 20);
		frame.getContentPane().add(btnMove);
		btnMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				game.moveAround(ogre);
				game.moveAround(enemy);
			}
		});

		//sets the size of btnUndo and tells the system what to do when it is pressed
		btnUndo.setVisible(true);
		btnUndo.setBounds(210, 420, 75, 20);
		frame.getContentPane().add(btnUndo);
		btnUndo.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				game.undoMove();

			}
		});

		//sets the size of btnKinghts and tells the system what to do when it is pressed also sets the location of the label lblKnight
		btnKnights.setVisible(true);
		btnKnights.setBounds(80, 480, 50, 50);
		frame.getContentPane().add(btnKnights);
		lblKnight.setVisible(true);
		lblKnight.setBounds(80, 500, 50, 50);
		frame.getContentPane().add(lblKnight);
		btnKnights.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				game.changeDiet("Knight"); //Changes Ogres Diet to Knight in Shining Armour

			}
		});

		//sets the size of btnBigMac and tells the system what to do when it is pressed also sets the location of the label lblBigMac
		btnBigMac.setVisible(true);
		btnBigMac.setBounds(220, 480, 50, 50);
		frame.getContentPane().add(btnBigMac);
		lblMac.setVisible(true);
		lblMac.setBounds(180, 500, 100, 50);
		frame.getContentPane().add(lblMac);
		btnBigMac.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				game.changeDiet("Very Big Macs");//Changes Ogres Diet to Knight in Shining Armour

			}
		});
		//sets the size of btnOgreEnemy and tells the system what to do when it is pressed also sets the location of the label lblOgreEnemy
		btnOgreEnemy.setVisible(true);
		btnOgreEnemy.setBounds(320, 480, 50, 50);
		frame.getContentPane().add(btnOgreEnemy);
		lblOgreEnemy.setVisible(true);
		lblOgreEnemy.setBounds(320, 500, 100, 50);
		frame.getContentPane().add(lblOgreEnemy);
		btnOgreEnemy.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				game.changeDiet("Ogre Enemies");//Changes Ogres Diet to Knight in Shining Armour

			}
		});

		//Loop laying the cells down in GUI
		for(int r = 0; r < numRows; r++){
			for(int c = 0; c < numCols; c++){
				
				//Calls the swampSquare method to write the cells to the GUI
				backBoard.add(new swampSquare(r,c));
			}
		}


		//Refreshes the Panel and adds it to the Frame then Refreshes the Frame
		backBoard.repaint();
		frame.add(backBoard);
		frame.repaint();

		frame.setVisible(true);
	}
	//End of DrawSwamp constructor

	//Method refresh allows the access of refreshing the Panel to other classes
	public void refresh(){

		backBoard.repaint();
	}
	//End of refresh method

	//Start of class swampSquare which extends JComponent and is used to create the squares of the swamp
	private class swampSquare extends JComponent{

		private static final long serialVersionUID = 1L;
		private int x; //x position of the rectangle measured from top left corner
		private int y; //y position of the rectangle measured from top left corner

		//Constructor for swampSquare which has two parameters for the x and y coordinates 
		public swampSquare(int p, int q)
		{
			//sets the border of the cells to green to look like a swamp and uses the size of width and height to set the size of the cells
			this.setBorder(new LineBorder(Color.green, 2));
			this.setPreferredSize(new Dimension(width, height));

			x = p; //sets int x to p;
			y = q; // sets int y to q;

		}
		//End of swampSquare constructor
		
		//Start of method paintComponent has one parameter Graphics g
		public void paintComponent(Graphics g){

			//sets g to the Graphics2d class then sets the cells to rectangle draws them and sets the colour to Brown to make it look like a swamp
			Graphics2D g2 = (Graphics2D) g;
			Rectangle box = new Rectangle(x,y,width,height);
			g2.draw(box);
			g2.setPaint(new Color(156, 93, 82));
			g2.fill(box);
			
		}
		//End of method paintComponent

	}
	//End of swampSquare class

}
//End of DrawSwamp class