from applicants import Applicants
from datetime import datetime
import pickle


def Input(filename):
    size = int(input("Enter the amount of applicants you want to input: "))
    for i in range(size):
        full_name = input("Enter the full name: ")
        birth = input("Enter the birth date [DD.MM.YYYY]: ")
        sex = input("Enter the sex [Male/Female]: ")
        while (sex != "Male" and sex != "Female"):
            sex = input("Wrong data, enter using this format [Male/Female]: ")
        enterToFile(filename, full_name, birth, sex)


def createFile(filename):
    mode = input("If you want to append your input enter a. Otherwise enter w: ")
    while (mode != 'a' and mode != 'w'):
        mode = input("Enter correct letter: ")
    if mode == 'a':
        file = open(filename, 'ab')
        file.close()
    if mode == 'w':
        file = open(filename, 'wb')
        file.close()


def enterToFile(filename, full_name, birth, sex):
    with open(filename, 'ab') as file:
        pickle.dump(full_name, file)
        pickle.dump(birth, file)
        pickle.dump(sex, file)


def readFile(filename):
    applicant_list = []
    with open(filename, "rb") as file:
        while 1:
            try:
                full_name = pickle.load(file)
                birth = pickle.load(file)
                sex = pickle.load(file)
                applicant = Applicants(full_name, birth, sex)
                applicant_list.append(applicant)
                applicant.Output()
            except EOFError:
                break
    return applicant_list


def removeOldApplicants(list):
    temp_list = list.copy()
    print("\nRemoved applicants (>35 yo): ")
    for applicant in temp_list:
        if calculateAge(applicant.birth) > 35:
            list.remove(applicant)
            applicant.Output()


def writeNewFile(filename, list):
    with open(filename, 'w') as file:
        for applicant in list:
            if 18 <= calculateAge(applicant.birth) < 27 and applicant.sex == "Male":
                enterToFile(filename, applicant.full_name, applicant.birth, applicant.sex)


def calculateAge(birth):
    today = datetime.now()
    birth_date = datetime.strptime(birth, "%d.%m.%Y")
    age = (today - birth_date).days/365.25
    return age