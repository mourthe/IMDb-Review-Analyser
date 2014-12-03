

public class Main {

	/**
	 * @param args
	 * @throws Exception 
	 */
	public static void main(String[] args) throws Exception {
		
				Svm svm = new Svm("C:\\Projects\\Golang\\src\\dataset.arff", 10);
                svm.buildModel();
				System.out.println(svm.getResume());
				System.out.println("Teste de classificac�o real: " + svm.doRealTest());
		
	}
	

	
}
