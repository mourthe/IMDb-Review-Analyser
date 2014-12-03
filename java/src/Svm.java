import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

import java.util.Calendar;
import java.util.Random;

import weka.classifiers.Evaluation;
import weka.classifiers.functions.LibSVM;
import weka.core.Instance;
import weka.core.Instances;
import weka.core.SelectedTag;


public class Svm {

	private int folds = 10 ;
	private Instances data ;
	private Instance realTest ;
	private LibSVM svm = new LibSVM();
	Evaluation ev;
	
	public Svm(String pathFile, int folds){
		
		try {

			BufferedReader reader = new BufferedReader( new FileReader(pathFile));
			data = new Instances(reader);			
			reader.close();
			// setting class attribute
			data.setClassIndex(data.numAttributes() - 1);
			realTest = data.firstInstance();
			data.delete(0);
			this.folds = folds;
            svm.setKernelType(new SelectedTag(LibSVM.KERNELTYPE_LINEAR, LibSVM.TAGS_KERNELTYPE));
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}
	
	
	public void buildModel() throws Exception{
	
		ev = new Evaluation(data);
		try {
			ev.crossValidateModel(svm, data, folds, new Random(Calendar.MILLISECOND));
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
		
	public boolean doRealTest(){
		try {
			svm.buildClassifier(data) ;
			return svm.classifyInstance(realTest) == realTest.classValue();
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
