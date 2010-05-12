require 'pixel_life'

def main
	width, height = 200, 100
	grid = Grid.new width, height
	
	ant = Ant.new(
			:pos => center(width, height), 
			:direction => :north, 
			:grid => grid
		)	

	window = PixelWindow.new "Langton's Ant", grid
	window.on_update = lambda{ 
		begin
			ant.move 
		rescue
			window.on_update = nil
			puts "Ant moved out of the window."			
		end
	}
	window.on_draw = lambda{ window.draw_red(ant.pos) }
	window.show
end

def center width, height
	Pos.new(width / 2, height / 2)
end

class Ant
	attr_accessor :pos 
	def initialize args
		@pos = args[:pos]
		@direction = args[:direction]
		@grid = args[:grid]
		@legs = TurnHelper.new
	end
	def move
		turn = @grid.white?(@pos) ? :turn_right : :turn_left
		@grid.flip(@pos)
		send turn
		move_forward
	end
	def turn_right
		@direction = @legs.move @direction, :right
	end
	def turn_left
		@direction = @legs.move @direction, :left
	end
	def move_forward
		case @direction
		when :north
			@pos.height -= 1
		when :east
			@pos.width += 1
		when :south
			@pos.height += 1
		when :west
			@pos.width -= 1 
		else
			raise "Bad direction #{@direction}"
		end
	end
end

class TurnHelper
	DIRECTIONS = [:north, :east, :south, :west]
	def move current_direction, direction_to_move
		i = DIRECTIONS.index(current_direction)
		i = self.send(direction_to_move, i)
		DIRECTIONS[i]
	end
	private
	def right i
		i = i + 1
		i = 0 if i >= DIRECTIONS.length
		return i
	end
	def left i
		i = i - 1
		i = DIRECTIONS.length - 1 if i < 0
		return i
	end
end

main # runs the application
