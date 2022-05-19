from library import *

first_file = "input.txt"
second_file = "output.txt"

text = text_input()

write_file(first_file, text)
read_file(first_file)

change_file(first_file, second_file)
read_file(second_file)
