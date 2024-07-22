namespace utilities_for_developers.Services
{
    public class Generators
    {
        public Generators() { }

        public string GeneratePassword(int length = 8)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string password = "";

            Random rnd = new Random();
            while (0 < length--)
            {
                password += validChars[rnd.Next(validChars.Length)];
            }

            return password;
        }

        public string GenerateCPF()
        {
            Random random = new Random();
            int[] cpf = new int[11];

            // Gera os 9 primeiros dígitos aleatoriamente
            for (int i = 0; i < 9; i++)
            {
                cpf[i] = random.Next(0, 10);
            }

            // Calcula o primeiro dígito verificador
            cpf[9] = CalculateVerifierDigit(cpf, 10);

            // Calcula o segundo dígito verificador
            cpf[10] = CalculateVerifierDigit(cpf, 11);

            return string.Join("", cpf);
        }

        private int CalculateVerifierDigit(int[] cpf, int weight)
        {
            int sum = 0;
            for (int i = 0; i < weight - 1; i++)
            {
                sum += cpf[i] * (weight - i);
            }

            int remainder = sum % 11;
            if (remainder < 2)
            {
                return 0;
            }
            else
            {
                return 11 - remainder;
            }
        }
    }
}
