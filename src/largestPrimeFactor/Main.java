package largestPrimeFactor;

public class Main {

/*	The prime factors of 13195 are 5, 7, 13 and 29.

	What is the largest prime factor of the number 600851475143 ?*/
			
	public static void main(String[] args) {
		
		//This solution taken from: http://stackoverflow.com/questions/20812594/largest-prime-factor-java
		
		long x = 600851475143L;
	    long biggest = 0L;
	    
	    for(long i = 2L; i <= x; i++){
	        for(long l = 1L; l <= Math.sqrt(i); l++){
	            if(l % i == 0){
	                break;
	            } 
	            else{
	                while(x % i == 0){
	                    x /= i;
	                    biggest = i;
	                }
	            }
	        }
	    }
	    
	    System.out.println(biggest);
	}

}
