def text_input():
    text = ''
    print("Enter the text:\n Write @ at the beginning of a line to stop input.")
    while True:
        line = input()
        if line.find('@') == 0:
            break
        text += line + '\n'
    if text[-1] == '\n':
        text = text[:-1]
    return text


def write_file(filename, text):
    mode = input("If you want to append your input, enter a. Otherwise enter w: ")
    while (mode != 'a' and mode != 'w'):
        mode = input("Wrong letter, enter a or w: ")
    if mode == 'a':
        file = open(filename, "a")
        text = f"\n{text}"
    if mode == 'w':
        file = open(filename, "w")
    file.write(text)
    file.close()


def read_file(filename):
    with open(filename, "r") as file:
        print(f"Open {filename}\n{file.read()}\n")


def del_words(text):
    lines_list = text.split("\n")
    new_text = ""
    counter = 0
    for line in lines_list:
        words_list = line.split()
        new_line = ""
        for word in words_list:
            if not (len(word) == 1 and word.isalpha()):
                new_line += word + " "
            else:
                counter += 1
        new_text += new_line + "\n"
    return new_text, counter


def del_duplicates(text, separator):
    counter = 0
    for char in text:
        while char == separator and char * 2 in text:
            text = text.replace(char * 2, char, 1)
            counter += 1
    return text, counter


def change_file(oldFile, newFile):
    with open(oldFile, "r") as file:
        text = file.read()
        new_text, counter_space = del_duplicates(text, " ")
        new_text, counter_comma = del_duplicates(new_text, ",")
        new_text, counter_dot = del_duplicates(new_text, ".")
        new_text, counter_word = del_words(new_text)
        new_text += f"shrinked spaces - {counter_space}, commas - {counter_comma}, dots - {counter_dot}, words - {counter_word}"
        with open(newFile, "w") as new_file:
            new_file.write(new_text)