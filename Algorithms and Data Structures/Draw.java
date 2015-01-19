import java.io.*;

public class Draw {

	static int gridW=77, gridH=77;
	public static void main(String[] args) throws Exception {
		//String fileBase = "GasWaterElectricity";
		String fileBase = "GasWaterElectricity3";
		//String fileBase = "000cwHDLdata";
		BufferedReader b = new BufferedReader(
				new FileReader(fileBase+".txt"));
		PrintStream fo = new PrintStream(fileBase+".svg");
		StringBuffer chips = new StringBuffer();
		StringBuffer joins = new StringBuffer();
		int joinCount = 1;
		StringBuffer paths = new StringBuffer();
		String ln ;
		while ((ln = b.readLine()) != null){
			String [] wrds = ln.split("\\s+");
			if (wrds.length==0) continue; // A blank line
			int x0,y0,x1,y1;
			double t = 0.1;
			switch (wrds[0])
			{
			case "D":
				gridW = Integer.parseInt(wrds[1]);
				gridH = Integer.parseInt(wrds[2]);
				break;				
			case "C":
				x0 = Integer.parseInt(wrds[1]);
				y0 = Integer.parseInt(wrds[2]);
				x1 = Integer.parseInt(wrds[3]);
				y1 = Integer.parseInt(wrds[4]);
				chips.append(String.format("<rect x='%f' y='%f' width='%f' height='%f' rx='.2' ry='.2' fill='pink' stroke='black' stroke-width='.2'/>\n",
						x0+t,y0+t,x1+1-x0-2*t,y1+1-y0-2*t));
				break;
			case "J":
				x0 = Integer.parseInt(wrds[1]);
				y0 = Integer.parseInt(wrds[2]);
				x1 = Integer.parseInt(wrds[3]);
				y1 = Integer.parseInt(wrds[4]);
				double f = 0.04;
				joins.append(String.format("<circle cx='%f' cy='%f' r='.4' fill='white' stroke='blue' stroke-width='.1'/>\n",
						x0+.5,y0+.5));
				joins.append(String.format("<circle cx='%f' cy='%f' r='.4' fill='white' stroke='blue' stroke-width='.1'/>\n",
						x1+.5,y1+.5));
				joins.append(String.format("<g transform='translate(%f,%f) scale(%f,%f)'><text text-anchor='middle'>%d</text></g>\n",
						x0+.5,y0+0.7f,f,f,joinCount));
				joins.append(String.format("<g transform='translate(%f,%f) scale(%f,%f)'><text text-anchor='middle'>%d</text></g>\n",
						x1+.5,y1+0.7f,f,f,joinCount++));
				
				break;
			case "#"://A comment, ignore
				break;
			case "T":
				x0 = Integer.parseInt(wrds[1]);
				y0 = Integer.parseInt(wrds[2]);
				StringBuffer p = new StringBuffer();
				p.append("M"+(x0+.5)+" "+(y0+.5)+" l");
				for(int i=3;i<wrds.length;i++)
					for(int j=0;j<wrds[i].length();j++){
						switch (wrds[i].charAt(j))
						{
						case 'N':
							p.append(" 0 -1");
							break;
						case 'E':
							p.append(" l 1 0");
							break;
						case 'S':
							p.append(" 0 1");
							break;
						case 'W':
							p.append(" -1 0");
							break;
						}
					}
				paths.append(String.format("<path stroke='gray' stroke-width='.2' fill='none' d='%s'/>\n",p));
				break;
			}
		}
		b.close();
		fo.printf("<svg width='10cm' height='10cm' viewBox='0 0 %d %d' xmlns='http://www.w3.org/2000/svg' version='1.1'>\n",
				gridW,gridH);
		String s="";
		for(int i=0;i<gridW;i++)
			s += String.format("M %d 0 l 0 %d ",i,gridH);
		fo.printf("<path stroke='blue' stroke-width='.02' fill='none' d='%s'/>", s);
		s="";
		for(int i=0;i<gridH;i++)
			s += String.format("M 0 %d l %d 0 ",i,gridW);
		fo.printf("<path stroke='blue' stroke-width='.02' fill='none' d='%s'/>", s);
		fo.print(chips);
		fo.print(paths);
		fo.print(joins);
		fo.print("</svg>");
		fo.close();
	}
}
