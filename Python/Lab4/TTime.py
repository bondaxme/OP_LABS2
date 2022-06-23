from TTriad import TTriad
import Funcs


class TTime(TTriad):
    def __init__(self, number1, number2, number3):
        super().__init__(number1, number2, number3)

    def IncreaseNumber1(self, n):
        self.Number1 += n
        while (self.Number1 >= 24):
            self.Number1 -= 24

    def DecreaseNumber1(self, n):
        self.Number1 -= n
        while self.Number1 < 0:
            self.Number1 += 24

    def IncreaseNumber2(self, n):
        self.Number2 += n
        while self.Number2 >= 60:
            self.Number2 -= 60
            self.IncreaseNumber1(1)

    def DecreaseNumber2(self, n):
        self.Number2 -= n
        while self.Number2 < 0:
            self.Number2 += 60
            self.DecreaseNumber1(1)

    def IncreaseNumber3(self, n):
        self.Number3 += n
        while self.Number3 >= 60:
            self.Number3 -= 60
            self.IncreaseNumber2(1)

    def DecreaseNumber3(self, n):
        self.Number3 -= n
        while self.Number3 < 0:
            self.Number3 += 60
            self.DecreaseNumber2(1)


    def Output(self):
        print(
            f"{Funcs.ChangeFormat(self.Number1)}:{Funcs.ChangeFormat(self.Number2)}:{Funcs.ChangeFormat(self.Number3)}")