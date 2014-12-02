import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

import java.util.Calendar;
import java.util.Random;

import weka.classifiers.Evaluation;
import weka.classifiers.lazy.IBk;
import weka.core.Instance;
import weka.core.Instances;
import weka.core.neighboursearch.BallTree;


public class Knn {

	private int folds = 2 ;
	private Instances data ;
	private Instance realTest ;
	private IBk ibk = new IBk(1);
	Evaluation ev;
	
	public Knn(String pathFile, int folds){
		
		try {

			BufferedReader reader = new BufferedReader( new FileReader("E:\\Documentos\\PUC-Rio_Trabalhos\\IntArtificial\\MachineLearning\\PokeFiles\\pokemons_bestKn_noMissing.arff"));
			data = new Instances(reader);			
			reader.close();
			// setting class attribute
			data.setClassIndex(data.numAttributes() - 1);
			realTest = data.firstInstance();
			data.delete(0);
			this.folds = folds;
			
			ibk.setNearestNeighbourSearchAlgorithm(new BallTree());
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}
	
	
	public void buildModel() throws Exception{
	
		ev = new Evaluation(data);
		try {
			ev.crossValidateModel(ibk, data, folds, new Random(Calendar.MILLISECOND));
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
		
	public boolean doRealTest(){
		try {
			ibk.buildClassifier(data) ;
			return ibk.classifyInstance(realTest) == realTest.classValue();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return false;
	}

	
	public String getResume(){		
		return ev.toSummaryString();
		
	}
	

}
