using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string dna=nucleotide;
          string rna="";
          int len=dna.Length;
          for(int i=0;i<dna.Length;i++){
          if(dna[i]=='G')
            rna=rna+'C';
          else if(dna[i]=='C')
            rna=rna+'G';
          else if(dna[i]=='T')
            rna=rna+'A';
          else if(dna[i]=='A')
            rna=rna+'U';
          }
          
          return rna;
        }
    }
}
