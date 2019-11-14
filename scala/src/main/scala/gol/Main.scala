package gol

import cats.implicits._
import cats.effect.{ExitCode, IO, IOApp}

object Main extends IOApp {
  override def run(args: List[String]): IO[ExitCode] =
    (log("ciao") *> log("mondo")).as(ExitCode.Success)

  def log(s: String): IO[Unit] = IO {
    println(s)
  }
}
