from library import *


input_file = "input.bin"
output_file = "output.bin"

createFile(input_file)
Input(input_file)
print("\nThe list of applicants: ")
applicant_list = readFile(input_file)
removeOldApplicants(applicant_list)

writeNewFile(output_file, applicant_list)
print("\nThe list of applicants ready to army: ")
readFile(output_file)
