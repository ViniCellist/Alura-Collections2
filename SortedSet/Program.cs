namespace A1._3_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinisculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();
            //este conjunto é subconjunto do outro? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            //este conjunto contêm os mesmos elementos? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - IntersectWith
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);
        }
    }
}