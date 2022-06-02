class Applicants:
    def __init__(self, full_name, birth, sex):
        self.full_name = full_name
        self.birth = birth
        self.sex = sex

    def Output(self):
        print(f"Full name: {self.full_name}, birth: {self.birth}, sex: {self.sex}")