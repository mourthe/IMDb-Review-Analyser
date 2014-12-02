

public class Main {

	/**
	 * @param args
	 * @throws Exception 
	 */
	public static void main(String[] args) throws Exception {
		
				Knn knn = new Knn("E:\\Documentos\\PUC-Rio_Trabalhos\\IntArtificial\\MachineLearning\\PokeFiles\\pokemons_bestKn_noMissing.arff", 95);
				knn.buildModel();
				System.out.println(knn.getResume());
				System.out.println("Teste de classificacão real: " + knn.doRealTest());
		
	}
	

	
}
