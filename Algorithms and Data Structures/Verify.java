import java.io.*;
import java.util.*;

public class Verify {
	static int gridW=20, gridH=20;
	static int [][] grid;
	
	static void printGrid(int[][] g){
		for(int i=0;i<g.length;i++)
		{
			for(int j=0;j<g[i].length;j++)
				System.out.print(g[i][j]);
			System.out.println();
		}
	}
	public static void main(String[] args) throws Exception {
		grid = new int[gridH][];
		for(int i=0;i<grid.length;i++)
			grid[i] = new int[gridW];
		String fileBase = "Error01";
		BufferedReader b = new BufferedReader(
				new FileReader(fileBase+".txt"));
		String ln;
		while ((ln=b.readLine())!=null){
			String w[] = ln.split(" ");
			if (w[0].equals("C")){
				int x0 = Integer.parseInt(w[1]);
				int y0 = Integer.parseInt(w[2]);
				int x1 = Integer.parseInt(w[3]);
				int y1 = Integer.parseInt(w[4]);
				for(int x=x0;x<=x1;x++)
					for(int y=y0;y<=y1;y++)
						if (grid[x][y]!=0){
							System.out.println("Moan...");
							
						}
						else
							grid[x][y] = 1;
			}
		}
		printGrid(grid);

	}	
}
