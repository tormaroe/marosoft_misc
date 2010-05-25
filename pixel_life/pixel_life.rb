require 'gosu'

class PixelWindow < Gosu::Window
	attr_writer :on_update, :on_draw
	# The magic number '2' is the size of each cell (duplicated for performance reasons)
	def initialize title, grid
		@grid = grid
		super @grid.width * 2, @grid.height * 2, false
		self.caption = title
		@counter = 0

		@white = Gosu::Image.new(self, "white.png", true)
		@red   = Gosu::Image.new(self, "red.png",   true)

		@time = Time.now
	end
	def update
		@on_update.call if @on_update
		count_off
	end
	def count_off
		@counter += 1
		if @counter % 100 == 0
			puts "#{@counter} steps completed in #{Time.now - @time} seconds"
		 	@time = Time.now	
		end
	end
	
	def draw
		@grid.cells.each do |cell|
			@white.draw(
				cell.pos.width * 2, 
				cell.pos.height * 2, 
				0) if cell.color == :white
		end
		@on_draw.call if @on_draw
	end
	def draw_red pos
		@red.draw(pos.width * 2, pos.height * 2, 0)
	end
end

class Pos < Struct.new(:width, :height); end

class Cell < Struct.new(:pos, :color); end

class Grid
	attr_reader :cells, :width, :height
	def initialize width, height
		@width, @height = width, height
		initialize_cells
	end
	def initialize_cells
		@cells = []
		for i in 1..@height do
			for j in 1..@width do
				@cells <<  Cell.new(Pos.new(j, i), :black)
			end
		end
	end
	def white? pos
		@cells[index_for_pos(pos)].color == :white
	end
	def flip pos
		c = @cells[index_for_pos(pos)]
		c.color = c.color == :black ? :white : :black 
	end
	def index_for_pos pos
		if pos.width < 1 or pos.height < 1 or pos.width > @width or pos.height > @height
			raise "invalid_position"
		end
		(@width * (pos.height-1)) + pos.width
	end
	def cell_at pos
		@cells[index_for_pos(pos)]
	end
end

